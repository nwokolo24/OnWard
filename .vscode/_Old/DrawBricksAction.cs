using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnWard.Game.Casting;
using OnWard.Game.Services;

namespace OnWard.Game.Scripts
{
    public class DrawBricksAction : Action
    {
        private VideoService videoService;
        
        public DrawBricksAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            List<Actor> bricks = cast.GetActors(Constants.BRICK_GROUP);
            foreach (Actor actor in bricks)
            {
                Brick brick = (Brick)actor;
                Body body = brick.GetBody();

                if (brick.IsDebug())
                {
                    Rectangle rectangle = body.GetRectangle();
                    Point size = rectangle.GetSize();
                    Point pos = rectangle.GetPosition();
                    videoService.DrawRectangle(size, pos, Constants.PURPLE, false);
                }

                Animation animation = brick.GetAnimation();
                Image image = animation.NextImage();
                Point position = body.GetPosition();
                videoService.DrawImage(image, position);
            }
        }
    }
}