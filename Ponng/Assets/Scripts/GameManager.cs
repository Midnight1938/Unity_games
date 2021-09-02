using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle compPaddle;

    public Text playerScoreText;
    public Text compScoreText;

    private int _playerScore;
    private int _compScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }
    public void CompScores()
    {
        _compScore++;
        this.compScoreText.text = _compScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.ball.ResetPos();
        this.playerPaddle.resetPosition();
        this.compPaddle.resetPosition();
        this.ball.AddStartingForce();

    }
}
