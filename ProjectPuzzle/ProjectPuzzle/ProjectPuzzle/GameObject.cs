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
    abstract class GameObject
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Movement { get; set; }
        public Rectangle Hitbox { get; set; }
        public int Health { get; set; }
        public float MaxSpeed { get; set; }
        
        public bool alive;

        int maxHealth;

        public GameObject(Texture2D texture, Vector2 position, Vector2 movement, Rectangle hitbox, int health, float maxSpeed)
        {
            this.Texture = texture;
            this.Position = position;
            this.Movement = movement;
            this.Hitbox = hitbox;
            this.Health = health;
            this.MaxSpeed = maxSpeed;

            this.maxHealth = this.Health;
            this.alive = true;
        }

        public virtual void Update(GraphicsDevice graphicsDevice)
        {
            this.Position += this.Movement;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Texture, this.Position, Color.White);
        }
    }
}
