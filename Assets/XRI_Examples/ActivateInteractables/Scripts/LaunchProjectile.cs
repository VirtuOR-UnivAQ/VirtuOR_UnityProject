namespace UnityEngine.XR.Content.Interaction
{
    /// <summary>
    /// Apply forward force to instantiated prefab
    /// </summary>
    public class LaunchProjectile : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The projectile that's created")]
        GameObject m_ProjectilePrefab = null;

        [SerializeField]
        [Tooltip("The point that the project is created")]
        Transform m_StartPoint = null;

        [SerializeField]
        [Tooltip("The speed at which the projectile is launched")]
        float m_LaunchSpeed = 1.0f;

        [SerializeField]
        [Tooltip("Il suono da riprodurra quando sparo")]
        AudioSource m_audioFeedback = null;

        [SerializeField]
        [Tooltip("Il ritardo in secondi tra le esecuzioni di Fire")]
        float m_fireDelay = 1.0f;

        private bool canFire = false;
        private float lastFireTime = 0.0f;

        public void Update()
        {
          // Controlla se il ritardo tra le esecuzioni di Fire è trascorso
            if (!canFire)
            {
                lastFireTime += Time.deltaTime;
                if (lastFireTime >= m_fireDelay)
                {
                    canFire = true;
                    lastFireTime = 0.0f;
                }
            }
         
        }
        public void Fire()
        {
            if(canFire){
                m_audioFeedback.Play();
                GameObject newObject = Instantiate(m_ProjectilePrefab, m_StartPoint.position, m_StartPoint.rotation, null);

                if (newObject.TryGetComponent(out Rigidbody rigidBody) && canFire)
                    ApplyForce(rigidBody);
            
                canFire = false;

        }

        void ApplyForce(Rigidbody rigidBody)
        {
            Vector3 force = m_StartPoint.forward * m_LaunchSpeed;
            rigidBody.AddForce(force);
        }
    }
}
}
