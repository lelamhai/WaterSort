using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    [SerializeField] private BottleController _bottle1;
    [SerializeField] private BottleController _bottle2;

    private bool _canPour = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos2d = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(pos2d, Vector2.zero);

            if (hit.collider == null) return;

            BottleController bottle = hit.collider.GetComponent<BottleController>();
            
            
            if (_bottle1 == null)
            {
                _bottle1 = bottle;
            }
            else if (_bottle2 == null && bottle != _bottle1)
            {
                if (bottle.Slots <= bottle.ListColor.Count) return;
                _bottle2 = bottle;

                Direction();
                MoveBottle();
            }
        }
    }

    private void Direction()
    {
        if (_bottle1.transform.position.x < _bottle2.transform.position.x)
        {
            _bottle1.Direction = -1;
        }
    }

    private void MoveBottle()
    {
        Vector3 target = _bottle2.Points[0].position;
        if (Vector3.Distance(_bottle1.transform.position, _bottle2.Points[0].position) > Vector3.Distance(_bottle1.transform.position, _bottle2.Points[1].position))
        {
            target = _bottle2.Points[1].position;
        }
        _bottle1.MoveBottle(_bottle1.transform.position, target);
    }

    public void Clear()
    {
        _bottle1 = null;
        _bottle2 = null;
    }

    protected override void SetDefaultValue()
    { }
}
