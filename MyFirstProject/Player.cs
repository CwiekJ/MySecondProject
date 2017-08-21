using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondProject
{
    class Player
    {
        Sprite sprite = new Sprite();

        public Player()
        {
        }

        public void Load(ContentManager content)
        {
            sprite.Load(content, "hero");
        }

        public void Update(float deltaTime)
        {
            sprite.Update(deltaTime);
        }

        public void Draw(spriteBatch spirteBatch)
        {
            sprite.Draw(spriteBatch);
        }
    }
}
