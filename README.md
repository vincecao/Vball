# Vball

###[Video demo] (https://www.youtube.com/watch?v=HBlhgqXjCUg "Vball")###

VBALL is a little desktop ball (ping pong) game with several specific features, which contains both single and multiply modes. 

The main operation for moving the rackets in the game is clicking by using the mouse and pressing key on the keyboard. 

There are two different control settings in the game, *autoMoving* and *manualMoving*, which enable the user to customize the type of controlling.

This game is mainly using two different colours in the interface part to keep the elements clear and apparent.

_*require /font/intro.otf font*_

## Screenshots ##
### Multi Mode ###
![](/img/screenshots/MultiMode.png "Multi Mode")

### Single Mode ###
![](/img/screenshots/SingleMode1.png "Single Mode")

![](/img/screenshots/SingleMode2.png "Single Mode")

![](/img/screenshots/SingleMode3-MenuPanel.png "Menu Pane")

![](/img/screenshots/SingleMode4-ControlPanel.png "Control Panel")

## Partial Code ##
### For realizing the default of full screen ###
<!--lang: C#-->
```ruby
this.FormBorderStyle = FormBorderStyle.None;
this.TopMost = true;
this.Bounds = Screen.PrimaryScreen.Bounds;
```

### Set the default location of the rackets ###
<!--lang: C#-->
```ruby
racket1.Left = 0;
racket1.Top = playground.Bottom * 9 / 10;

racket2.Left = (playground.Width - racket2.Width) * 1 / 2;
racket2.Top = playground.Bottom * 1 / 10;
```

### Make the racket moving with the mouse’ movement (Using with Timer) ###
<!--lang: C#-->
```ruby
racket1.Left = Cursor.Position.X - (racket1.Width / 2);
```

### Make the ball movement (Using with Timer) ###
<!--lang: C#-->
```ruby
ball.Left += speed_left;
ball.Top += speed_top;
```

### Finding the relationship between ball, rackets and playground for realizing the bounce in each mode (Using with timer) ###
<!--lang: C#-->
```ruby
if (ball.Bottom >= racket1.Top && ball.Bottom <= racket1.Bottom && ball.Right >= racket1.Left && ball.Left <= racket1.Right)
{
    if (modeselect == 0)
    {
        //
    }
    else if (modeselect == 1)
    {
        //
    }

}
else if (ball.Top < racket2.Bottom && ball.Top > racket2.Top && ball.Right >= racket2.Left && ball.Left <= racket2.Right)
{
    if (modeselect == 0)
    {
        //
    }
    else if (modeselect == 1)
    {
        //
    }
}
else if (ball.Left <= playground.Left || ball.Right >= playground.Right)
{
    speed_left = -speed_left;
}
else if (ball.Top <= playground.Top)
{
    if (modeselect == 0)
    {
        //
    }
    else if (modeselect == 1)
    {
        //
    }


}
else if (ball.Bottom >= playground.Bottom)
{
    if (modeselect == 0)
    {
        //
    }
    else if (modeselect == 1)
    {
        //
    }

}
```
### Listening the key and make corresponding action (Using with KeyDownEvents) ###
<!--lang: C#-->
```ruby
if (e.KeyCode == Keys.Escape)
{
    this.Close();
}
if (e.KeyCode == Keys.F1)
{
    timer1.Stop();
    timer2.Stop();
    MenuPanel.Show();
    playIcon.Hide();
    pauseIcon.Show();

}
if (e.KeyCode == Keys.F2)
{
    timer1.Start();
    //timer2.Start();
    MenuPanel.Hide();
    playIcon.Show();
    pauseIcon.Hide();
}
```

### For autoMoving Controlling (Using with KeyDownEvents) ###
<!--lang: C#-->
```ruby
if (e.KeyCode == Keys.Left)
{

    if (timer2.Enabled == false && key_increse > 0)
    {
        timer2.Start();
        timer2.Interval = 5;
    }
    else if (timer2.Enabled == true && key_increse > 0)
    {
        timer2.Enabled = false;
    }
    else if (timer2.Enabled == false && key_increse < 0)
    {
        key_increse = -key_increse;
        timer2.Start();
        timer2.Interval = 5;
    }
    else if (timer2.Enabled == true && key_increse < 0)
    {
        key_increse = -key_increse;
        timer2.Enabled = false;
    }

}
else if (e.KeyCode == Keys.Right)
{

    if (timer2.Enabled == false && key_increse < 0)
    {
        timer2.Start();
        timer2.Interval = 5;
    }
    else if (timer2.Enabled == true && key_increse < 0)
    {
        timer2.Enabled = false;
    }
    else if (timer2.Enabled == false && key_increse > 0)
    {
        key_increse = -key_increse;
        timer2.Start();
        timer2.Interval = 5;
    }
    else if (timer2.Enabled == true && key_increse > 0)
    {
        key_increse = -key_increse;
        timer2.Enabled = false;
    }
}
```

### For manualMoving Controlling (Using with KeyDownEvents) ###
<!--lang: C#-->
```ruby
if (e.KeyCode == Keys.Left && Control.ModifierKeys == Keys.Alt)
{
    racket2.Left -= 7 * key_increse;

}
else if (e.KeyCode == Keys.Right && Control.ModifierKeys == Keys.Alt)
{
    racket2.Left += 7 * key_increse;

}
else if (e.KeyCode == Keys.Left && Control.ModifierKeys != Keys.Alt)
{
    racket2.Left -= key_increse;

}
else if (e.KeyCode == Keys.Right && Control.ModifierKeys != Keys.Alt)
{

    racket2.Left += key_increse;

}
```

### For Up Racket moving in autoMoving Controlling (Using with new Timer) ###
<!--lang: C#-->
```ruby
private void timer2_Tick(object sender, EventArgs e)
{
    if (racket2.Left > playground.Left && racket2.Right < playground.Right)
    {
        racket2.Left -= key_increse;
    }
    else
    {
        key_increse = -key_increse;
        racket2.Left -= key_increse;
        timer2.Stop();
    }

}
```

## Reference ##

- TcKs. *[How to display a Windows Form in full screen on top of the taskbar? [duplicate]](http://stackoverflow.com/questions/2272019/how-to-display-a-windows-form-in-full-screen-on-top-of-the-taskba)*

- Microsoft. *[Timer Class](https://msdn.microsoft.com/en-us/library/system.threading.timer(v=vs.110).aspx)*
