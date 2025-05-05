using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioOcclusion : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Drag your AudioListener (e.g. your player camera) here.")]
    public Transform listener;

    [Header("Audio Settings")]
    [Tooltip("Should match your AudioSource.maxDistance")]
    public float maxDistance = 190f;

    [Tooltip("Base volume when fully occluded (0 = silent, 1 = full volume)")]
    [Range(0f, 1f)]
    public float occludedVolume = 0.1f;

    [Header("Occlusion Settings")]
    [Tooltip("Select the layer(s) used by your maze walls")]
    public LayerMask occlusionMask;

    [Tooltip("How much each wall intersection pushes volume toward occludedVolume (e.g. 0.2 per wall)")]
    [Range(0f, 1f)]
    public float perWallOcclusionFactor = 0.1f;

    // private
    private AudioSource src;
    private float currentVolume = 1f;

    void Awake()
    {
        src = GetComponent<AudioSource>();
        // Ensure 3D sound
        src.spatialBlend = 1f;
        src.maxDistance = maxDistance;
        src.rolloffMode = AudioRolloffMode.Logarithmic;
    }

    void Update()
    {
        if (listener == null) return;

        Vector3 dir = listener.position - transform.position;
        float dist = dir.magnitude;

        // Debug ray
        Debug.DrawRay(transform.position, dir, Color.red);

        if (dist > maxDistance)
        {
            // Beyond range
            currentVolume = 0f;
        }
        else
        {
            // Check occlusion
            RaycastHit firstHit;
            bool isOccluded = Physics.Raycast(transform.position, dir.normalized, out firstHit, dist, occlusionMask);

            if (isOccluded)
            {
                // Distance‑based blend (0 at source → 1 at maxDistance)
                float distT = dist / maxDistance;
                float baseMuffled = Mathf.Lerp(1f, occludedVolume, distT);

                // Count all wall intersections
                RaycastHit[] allHits = Physics.RaycastAll(transform.position, dir.normalized, dist, occlusionMask);
                int wallCount = allHits.Length;
                float wallT = Mathf.Clamp01(wallCount * perWallOcclusionFactor);

                // Combine: first distance, then deepen by wall count
                currentVolume = Mathf.Lerp(baseMuffled, occludedVolume, wallT);

                Debug.Log($"Occluded by {firstHit.collider.name}, walls: {wallCount}, volume: {currentVolume:F2}");
            }
            else
            {
                // Clear line of sight
                currentVolume = 1f;
            }
        }

        src.volume = currentVolume;
    }

    void OnGUI()
    {
        // Display volume for quick verification
        GUI.Label(new Rect(10, 10, 250, 20), $"Volume: {currentVolume:F2}");
    }
}
