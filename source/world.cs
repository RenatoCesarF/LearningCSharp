using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Mars.Components;
using Mars.Primitivies;

namespace Mars{
    public class World{
        public Line2D line;
        public static RigidBody2D square,square2;
        private Basic2D basic;
        public World(Game game){
            square = new RigidBody2D(game,new Vector2(10,50),Color.Orange, mass:0.2f);
            square2 = new RigidBody2D(game,new Vector2(10,10), Color.CornflowerBlue, mass:0.5f);
            basic = new Basic2D("sprite", new Vector2(100,30),new Vector2(100,100));
            line = new Line2D( new LineSegment(new Vector2(40,20), new Vector2(40,250)));
        }
        public virtual void Update(){
            square.Update();
            square2.Update();
            line.Update();
            basic.Update();
        }
        public virtual void Draw(Vector2 OFFSET){
            square.Draw(OFFSET);
            square2.Draw(OFFSET);
            line.Draw(OFFSET);
            basic.Draw(OFFSET);
        }
    }
}