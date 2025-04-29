using UnityEngine;

public class DescriptionText : MonoBehaviour
{
   public GameObject DescriptionPanel;

   public void TargetFound()
   {
    DescriptionPanel.SetActive(true);
   }

  public void TargetLost()
   {
    DescriptionPanel.SetActive(false);
   }
}
