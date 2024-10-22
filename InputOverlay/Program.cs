using Raylib_cs;

namespace InputMania
{
    static class Program
    {
        public static void Main()
        {
            const int screen_width = 350;
            const int screen_height = 200;
            Raylib.InitWindow(screen_width, screen_height, "Inputs - [by Linirby]");

            Color HUD_text_color = Color.BLACK;

            string key_1 = "A";
            string key_2 = "S";
            string key_3 = "K";
            string key_4 = "L";

            Color color_key_1 = Color.BLACK;
            Color color_key_2 = Color.BLACK;
            Color color_key_3 = Color.BLACK;
            Color color_key_4 = Color.BLACK;

            int highlight_color_id = 1;
            Color highlight_color = Color.MAGENTA;

            int square_x = screen_width - 40;

            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                if (highlight_color_id == 1) highlight_color = Color.MAGENTA;
                if (highlight_color_id == 2) highlight_color = Color.GOLD;
                if (highlight_color_id == 3) highlight_color = Color.SKYBLUE;
                if (highlight_color_id == 4) highlight_color = Color.LIME;
                if (highlight_color_id == 5) highlight_color = Color.ORANGE;

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT) && highlight_color_id < 5) highlight_color_id += 1;
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) && highlight_color_id > 1) highlight_color_id -= 1;

                if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP)) HUD_text_color = Color.BLACK;
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN)) HUD_text_color = Color.WHITE;
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP)) square_x = screen_width - 40;
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN)) square_x = screen_width;

                if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) color_key_1 = highlight_color;
                    else color_key_1 = Color.BLACK;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_S)) color_key_2 = highlight_color;
                    else color_key_2 = Color.BLACK;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_SEMICOLON)) color_key_3 = highlight_color;
                    else color_key_3 = Color.BLACK;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_APOSTROPHE)) color_key_4 = highlight_color;
                    else color_key_4 = Color.BLACK;

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Your Inputs : ", 10, 10, 30, HUD_text_color);
                Raylib.DrawText(highlight_color_id.ToString() + "/5", screen_width - 80, 16, 20, HUD_text_color);
                Raylib.DrawText("(" + key_1 + key_2 + key_3 + key_4 + ")        change color : <- ->", 10, 45, 20, HUD_text_color);

                Raylib.DrawText(key_1, 10, 90, 40, color_key_1);
                Raylib.DrawText(key_2, 55, 90, 40, color_key_2);
                Raylib.DrawText(key_3, 100, 90, 40, color_key_3);
                Raylib.DrawText(key_4, 145, 90, 40, color_key_4);

                Raylib.DrawText("Press DOWN ARROW to hide HUD", 10, screen_height - 30, 20, HUD_text_color);
                Raylib.DrawText("Press UP ARROW to see HUD", 10, screen_height - 55, 20, HUD_text_color);

                Raylib.DrawRectangle(square_x, 10, 30, 30, highlight_color);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}