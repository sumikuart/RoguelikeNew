﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roguelike.Class.World
{

    class Level : GameObject
    {

        private Rectangle borderSize;
        private List<Environment> enviromentList;


        public List<Environment>  EnviromentList
        {
            get
            {
                return enviromentList;
            }
            }

        public Level(int mapSizeWidth, int mapSizeHeight, List<Environment> enviromentList)
        {
            borderSize = new Rectangle(0, 0, mapSizeWidth, mapSizeHeight);
            this.enviromentList = enviromentList;
        }

     


        public override void LoadContent(ContentManager content)
        {


        }

        public override void OnCollision(GameObject gameObject)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {

        }

    }
}
