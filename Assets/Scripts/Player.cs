using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;



    private void Start ()
    {
       _numSeedsLeft = _numSeeds;
       _numSeedsPlanted = 0;
       _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
        
    }

    private void Update()
    {
        float _xval = Input.GetAxis("Horizontal");
        float _yval = Input.GetAxis("Vertical");

        Vector3 _movement = new Vector3(_xval, _yval, 0f);
        transform.position += _movement * _speed * Time.deltaTime;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_numSeedsLeft > 0)
            {
                PlantSeed();
            }   
        }
        
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    public void PlantSeed ()
    {
        GameObject _seed = Instantiate(_plantPrefab);
        _seed.transform.position = transform.position;
        _numSeedsLeft--;
        _numSeedsPlanted++;
    }
}
