use bevy::prelude::*;

mod components;
mod systems;
mod resources;
mod constants;

use components::*;
use resources::*;
use systems::*;
use constants::*;

fn main() {
    App::new()
        .add_plugins(DefaultPlugins.set(WindowPlugin {
            primary_window: Some(Window {
                title: "Rare Fish Game".to_string(),
                resolution: (WINDOW_WIDTH, WINDOW_HEIGHT).into(),
                ..default()
            }),
            ..default()
        }))
        // Resources
        .insert_resource(ClearColor(BACKGROUND_COLOR))
        .init_resource::<GameState>()
        .init_resource::<WorldSeed>()
        // Startup systems
        .add_systems(Startup, (
            setup_camera,
            setup_ui,
            generate_tilemap,
        ).chain())
        // Update systems
        .add_systems(Update, (
            handle_tile_clicks,
            handle_uncle_selection,
            handle_cash_out,
            update_ui,
            uncle_fishing_system,
            fish_escape_system,
            cooldown_system,
            animate_fish,
        ))
        .run();
}
