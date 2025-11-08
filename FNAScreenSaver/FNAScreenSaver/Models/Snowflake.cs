using FNAScreenSaver.AppConstants;

namespace FNAScreenSaver.Models
{
    /// <summary>
    /// Класс снежинки
    /// </summary>
    public class Snowflake
    {
        /// <summary>
        /// Координата X
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Координата Y
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Скорость снежинки
        /// </summary>
        public float Speed { get; set; }

        /// <summary>
        /// Масштаб снежинки
        /// </summary>
        public float Scale { get; set; }

        /// <summary>
        /// Цвет с альфой
        /// </summary>
        public Microsoft.Xna.Framework.Color Color { get; set; } = Microsoft.Xna.Framework.Color.LightBlue;

        private readonly float swayOffset = Random.Shared.NextSingle() * 10f;

        /// <summary>
        /// Обновляет позицию снежинки
        /// </summary>
        public void Update(float deltaTime)
        {
            Y += Speed * deltaTime;
            X += MathF.Sin(Y * 0.05f + swayOffset) * 0.35f;
        }

        /// <summary>
        /// Здесь задаются параметры снежинки
        /// </summary>
        public void Reset(int startPosition)
        {
            Y = -Random.Shared.Next(Constants.MinStartY, Constants.MaxStartY);
            X = Random.Shared.Next(0, startPosition);

            Speed = Random.Shared.NextSingle() *
                     (Constants.MaxSpeed - Constants.MinSpeed) + Constants.MinSpeed;

            Scale = Random.Shared.NextSingle() *
                     (Constants.MaxScale - Constants.MinScale) + Constants.MinScale;

            var alpha = Random.Shared.NextSingle() *
                          (Constants.MaxAlpha - Constants.MinAlpha) + Constants.MinAlpha;

            Color = new Microsoft.Xna.Framework.Color(1f, 1f, 1f, alpha);
        }
    }
}
