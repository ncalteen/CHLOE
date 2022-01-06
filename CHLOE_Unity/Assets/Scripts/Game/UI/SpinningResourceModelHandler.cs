using UnityEngine;

public class SpinningResourceModelHandler : Singleton<SpinningResourceModelHandler>
{
    #region Variables
    private Transform resourceTransform;
    #endregion

    #region Properties
    public Transform ResourceTransform
    {
        get { return this.resourceTransform; }
        set { this.resourceTransform = value; }
    }
    #endregion

    #region Unity
    private void Update()
    {
        if (this.resourceTransform != null)
        {
            this.resourceTransform.transform.Rotate(0f, 50f * Time.deltaTime, 0f);
        }
    }
    #endregion
}
