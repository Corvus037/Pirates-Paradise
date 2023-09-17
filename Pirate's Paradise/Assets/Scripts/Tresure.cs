using UnityEngine;

public class Tresure : MonoBehaviour
{
    public GameObject[] possibleTreasures;  // Lista de possíveis alvos "tesouros"
    private GameObject currentTreasure;     // O alvo atualmente marcado como "tesouro"
    public float treasureChangeInterval = 3f;  // Intervalo de mudança de tesouro em segundos
    private float timer = 0f;  // Contador de tempo decorrido

    void Start()
    {
        // Inicialmente, nenhum tesouro está definido.
        currentTreasure = null;
    }

    void Update()
    {
        // Atualiza o temporizador.
        timer += Time.deltaTime;

        // Verifique se o tempo decorrido atingiu o intervalo de mudança desejado.
        if (timer >= treasureChangeInterval)
        {
            // Escolhe um novo tesouro aleatório.
            ChooseRandomTreasure();

            // Redefine o temporizador.
            timer = 0f;
        }
    }

    void ChooseRandomTreasure()
    {
        // Escolhe um índice aleatório na lista de objetos possíveis.
        int randomIndex = Random.Range(0, possibleTreasures.Length);

        // Marca o objeto escolhido como "tesouro".
        currentTreasure = possibleTreasures[randomIndex];

        // Ative ou desative o componente "TreasureTarget" no objeto selecionado conforme necessário.
        // Por exemplo: currentTreasure.GetComponent<TreasureTarget>().ToggleActivation();
    }
}