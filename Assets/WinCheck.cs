using UnityEngine;

public class WinCheck : Block
{
    private void Update()
    {
        Cell checkCell = gridManager.gridList[gridPos.x][gridPos.y].GetComponent<Cell>();
        Debug.Log(checkCell.CheckContainObj());
    }

    public override void SetNewGridPos(GameObject _parent, int _gridX, int _gridY)
    {
        //_parent.GetComponent<Cell>().ContainObj = gameObject;
        transform.SetParent(_parent.transform);
        gridPos.Set(_gridX, _gridY);
    }
}
