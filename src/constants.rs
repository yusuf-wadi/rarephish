use bevy::prelude::*;

// Window
pub const WINDOW_WIDTH: f32 = 1400.0;
pub const WINDOW_HEIGHT: f32 = 900.0;

// Colors
pub const BACKGROUND_COLOR: Color = Color::srgb(0.059, 0.090, 0.165);
pub const SURFACE_COLOR: Color = Color::srgb(0.118, 0.161, 0.231);
pub const PRIMARY_COLOR: Color = Color::srgb(0.220, 0.741, 0.973);
pub const GOLD_COLOR: Color = Color::srgb(0.984, 0.749, 0.141);
pub const WATER_COLOR: Color = Color::srgb(0.047, 0.290, 0.431);
pub const LAND_COLOR: Color = Color::srgb(0.086, 0.639, 0.290);

// Tilemap
pub const TILE_SIZE: f32 = 40.0;
pub const TILEMAP_WIDTH: usize = 16;
pub const TILEMAP_HEIGHT: usize = 12;
pub const TILEMAP_OFFSET_X: f32 = -350.0;
pub const TILEMAP_OFFSET_Y: f32 = 50.0;

// Gameplay
pub const CASH_OUT_COOLDOWN: f32 = 30.0; // seconds
pub const STARTING_GOLD: i32 = 100;

// Fish escape chances
pub const COMMON_ESCAPE_CHANCE: f32 = 0.05;
pub const UNCOMMON_ESCAPE_CHANCE: f32 = 0.20;
pub const RARE_ESCAPE_CHANCE: f32 = 0.40;

// Uncle types
pub const MONGOLIAN_COST: i32 = 50;
pub const MONGOLIAN_SPEED: f32 = 2.0;

pub const SOMALI_COST: i32 = 150;
pub const SOMALI_SPEED: f32 = 1.5;

pub const JAPANESE_COST: i32 = 300;
pub const JAPANESE_SPEED: f32 = 2.5;
pub const JAPANESE_RARE_BONUS: f32 = 0.05;
