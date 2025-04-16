using UnityEngine;

public static class ActiveModelTracker
{
    public static GameObject GetActiveModel()
    {
        GameObject[] imageTargets = GameObject.FindGameObjectsWithTag("ImageTarget");

        foreach (GameObject target in imageTargets)
        {
            if (target.transform.childCount == 0) continue;

            Transform model = target.transform.GetChild(0);
            MeshRenderer meshRenderer = model.GetComponent<MeshRenderer>();

            if (meshRenderer != null && meshRenderer.enabled)
            {
                return model.gameObject;
            }
        }

        return null;
    }
}