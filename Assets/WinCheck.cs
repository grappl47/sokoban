using UnityEngine;

public class WinCheck : Block
{
    Cell checkCell;
    bool hasObject = false;
    LevelManager levelManager;
    [SerializeField] GameObject winLight;
    AudioSource AudioSource;

    private void Start()
    {
        checkCell = gridManager.gridList[gridPos.x][gridPos.y].GetComponent<Cell>();
        hasObject = false;
        levelManager = LevelManager.instance;
        winLight.SetActive(false);
        AudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (hasObject && !checkCell.CheckContainObj())
        {
            levelManager.numWinChecks--;
            hasObject = false;
            winLight.SetActive(false);
        }
        else if (!hasObject && checkCell.CheckContainObj())
        {
            levelManager.numWinChecks++;
            hasObject = true;
            winLight.SetActive(true);
            AudioSource.Play();
        }
    }

    public override void SetNewGridPos(GameObject _parent, int _gridX, int _gridY)
    {
        transform.SetParent(_parent.transform);
        gridPos.Set(_gridX, _gridY);
    }
}
