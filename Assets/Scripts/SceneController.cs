using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;
using System.Threading.Tasks;

public class SceneController : MonoBehaviour
{
    public GameObject main;
    [SerializeField] private string _lionlabel;
    [SerializeField] private string _ratlabel;
    //[SerializeField] private AssetReference _LionRef;
    //[SerializeField] AssetReference _RatRef;
    //[SerializeField] private List<GameObject> _completedObj = new List<GameObject>();
    public void OnClickLion()
    {
        Get(_lionlabel);
        //AssetRefLoader.CreateAssetAddToList(_LionRef, _completedObj);
        //SceneManager.LoadScene("LionCard");
    }
    public void OnClickRat()
    {
        Get(_ratlabel);
        //AssetRefLoader.CreateAssetAddToList(_RatRef, _completedObj);
        //SceneManager.LoadScene("RatCard");
    }

    public async Task Get(string label)
    {
        main.SetActive(false);
        Addressables.LoadSceneAsync(label);

        /*var locations = await Addressables.LoadScene(label).Task;

        foreach (var location in locations)
        {
            await Addressables.InstantiateAsync(location).Task;
        }*/
    }
}
