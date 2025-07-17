using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using System.Security.Cryptography.X509Certificates;

namespace sleepwalking_master;

public class Main : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public const int ViewportWidth = 480;
    public const int ViewportHeight = 480;

    private SpriteFont font;

    private Frog playerFrog;

    public Main()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferWidth = ViewportWidth;
        _graphics.PreferredBackBufferHeight = ViewportHeight;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        var greenTexture = new Texture2D(GraphicsDevice, 1, 1);
        greenTexture.SetData(new Color[] { Color.Green });

        playerFrog = new Frog(greenTexture, new Vector2(ViewportWidth / 2 - Frog.Width, ViewportHeight / 2 - Frog.Height));

        font = Content.Load<SpriteFont>("font");
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        var keyboardState = Keyboard.GetState();
        var gamePadState = GamePad.GetState(PlayerIndex.One);

        if (keyboardState.IsKeyDown(Keys.A) || gamePadState.DPad.Left == ButtonState.Pressed)
        {
            playerFrog.MoveLeft();
        }

        if (keyboardState.IsKeyDown(Keys.D) || gamePadState.DPad.Right == ButtonState.Pressed)
        {
            playerFrog.MoveRight();
        }

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Blue);

        _spriteBatch.Begin();

        _spriteBatch.DrawString(font, playerFrog.GetPosition().X.ToString(), new Vector2(ViewportWidth / 2, ViewportHeight / 2), Color.White);
        // currently a placeholder for the player
        _spriteBatch.Draw(playerFrog.GetTexture(), new Rectangle((int)playerFrog.GetPosition().X, (int)playerFrog.GetPosition().Y, Frog.Width, Frog.Height), Color.White);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
