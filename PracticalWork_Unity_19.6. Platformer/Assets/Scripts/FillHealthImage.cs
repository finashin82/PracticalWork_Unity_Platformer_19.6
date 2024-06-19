using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FillHealthImage : MonoBehaviour
{
    // Картинка для показа жизни
    [SerializeField] private Image _imageHP;

    /// <summary>
    /// Заливка картинки с жизнью
    /// </summary>
    /// <param name="health"></param>
    public void FillImage(Health health)
    {        
        _imageHP.fillAmount = health.CurrentHealth / health.MaxHealth;
    }
}
