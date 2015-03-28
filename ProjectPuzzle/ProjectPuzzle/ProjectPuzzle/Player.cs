using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ProjectPuzzle
{
    class Player : GameObject
    {
        public int Score { get; set; }

        public KeyboardState kState;
        public Keys[] keys;

        public Player(Texture2D texture, Vector2 position, Vector2 movement, Rectangle hitbox, int health, int score, float maxSpeed)
            : base(texture, position, movement, hitbox, health, maxSpeed)
        {
            this.Score = score;
        }

        public void Initialize()
        {
            kState = Keyboard.GetState();
            keys = new Keys[4];
            keys[0] = Keys.W;
            keys[1] = Keys.A;
            keys[2] = Keys.S;
            keys[3] = Keys.D;
        }

        public override void Update(GraphicsDevice graphicsDevice)
        {
            kState = Keyboard.GetState();
            if (kState.IsKeyDown(keys[0])) { this.Movement = new Vector2(0, -this.MaxSpeed); }
            else if (kState.IsKeyDown(keys[1])) { this.Movement = new Vector2(-this.MaxSpeed, 0); }
            else if (kState.IsKeyDown(keys[2])) { this.Movement = new Vector2(0, this.MaxSpeed); }
            else if (kState.IsKeyDown(keys[3])) { this.Movement = new Vector2(this.MaxSpeed, 0); }

            else if (kState.IsKeyUp(keys[0]) && kState.IsKeyUp(keys[1]) && kState.IsKeyUp(keys[2]) && kState.IsKeyUp(keys[3])) { this.Movement = new Vector2(0, 0); }

            base.Update(graphicsDevice);
        }
    }
}
