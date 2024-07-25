using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemCard : MonoBehaviour {
    private Sprite[] itemCards;
    private SpriteRenderer rend;
	private void Start () {
        rend = GetComponent<SpriteRenderer>();
        itemCards = Resources.LoadAll<Sprite>("ItemCards/");
	}

    private void OnMouseDown()
    {
        StartCoroutine("FlipCard");
    }

    private IEnumerator FlipCard()
    {
        int randomCardSide = 0;

        int finalSide = 0;

        for (int i = 0; i < 1; i++)
        {
            randomCardSide = Random.Range(0, 8);
            rend.sprite = itemCards[randomCardSide];
            yield return new WaitForSeconds(0.05f);
        }

        finalSide = randomCardSide + 1;
        Debug.Log(finalSide);
    }
}
