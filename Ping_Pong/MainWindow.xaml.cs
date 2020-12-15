using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Ping_Pong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _speedball = 3;
        private double _angleball = 155;
        private int Speedplayer = 15;     

        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("START");

            player1.DataContext = _player1;
            player2.DataContext = _player2;
            ball.DataContext = _ball;            

            var time = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(1) };
            time.Start();
            time.Tick += _timer_Tick;
            
        }
        
        public void _timer_Tick(object sender, EventArgs e)
        {
            double radians = (Math.PI / 180) * _angleball;
            Vector vector = new Vector { X = Math.Sin(radians), Y = -Math.Cos(radians) };
            _ball.X += vector.X * _speedball;
            _ball.Y += vector.Y * _speedball;

            if (_ball.Y <= 0) _angleball = _angleball + (180 - 2 * _angleball);
            if (_ball.Y >= MainCanvas.ActualHeight - 20) _angleball = _angleball + (180 - 2 * _angleball);
            if (Collision())
            {
                ChangeAngle();
                ChangeDirection();
            }

            if (_ball.X > 700)
            {
                GameReset();
            }
            if (_ball.X < 0)
            {
                GameReset();
            }
        }

        private void ChangeAngle()
        {
            if (_ball.MovingRight) _angleball = _angleball + (0 - 2 * _angleball);
            else _angleball = _angleball + (0 - 2 * _angleball);
        }
        
        private void ChangeDirection()
        {
            _ball.MovingRight = !_ball.MovingRight;
        }

        private bool Collision()
        {
            if (_ball.MovingRight)
                return (_ball.X >= 680 && _ball.Y > _player2.YPosition - 20 && _ball.Y < _player2.YPosition + 80);
            else
                return _ball.X <= 20 && (_ball.Y > _player1.YPosition - 20 && _ball.Y < _player1.YPosition + 80);
        }


        private void GameReset()
        {
            _ball.Y = 210;
            _ball.X = 300;
            _player1.YPosition = 90;
            _player2.YPosition = 70;
        }

        readonly Ball _ball = new Ball { X = 380, Y = 210, MovingRight = true };
        readonly Player _player1 = new Player { YPosition = 90 };
        readonly Player _player2 = new Player { YPosition = 70 };

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.W))
            {
                if (_player1.YPosition <= 0) _player1.YPosition = 0;
                else _player1.YPosition -= Speedplayer;
            }

            if (Keyboard.IsKeyDown(Key.S))
            {
                if (_player1.YPosition >= 300) _player1.YPosition = 300;
                else _player1.YPosition += Speedplayer;
            }
                
            if (Keyboard.IsKeyDown(Key.Up))
            {
                if (_player2.YPosition <= 0) _player2.YPosition = 0;
                else _player2.YPosition -= Speedplayer;
            }
                
            if (Keyboard.IsKeyDown(Key.Down))
            {
                if (_player2.YPosition >= 300) _player2.YPosition = 300;
                else _player2.YPosition += Speedplayer;
            }

            if (Keyboard.IsKeyDown(Key.Escape)) Application.Current.Shutdown();

            if (Keyboard.IsKeyDown(Key.F3)) _speedball += 1;

            if (Keyboard.IsKeyDown(Key.F4))
            {
                if (_speedball > 1) _speedball -= 1;
            }
        }
    }
}