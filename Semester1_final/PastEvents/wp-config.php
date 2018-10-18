<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://codex.wordpress.org/Editing_wp-config.php
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define('DB_NAME', 'i4082399_wp1');

/** MySQL database username */
define('DB_USER', 'i4082399_wp1');

/** MySQL database password */
define('DB_PASSWORD', 'A^^E2hDCn3B1#n[nPu.68#]2');

/** MySQL hostname */
define('DB_HOST', 'localhost');

/** Database Charset to use in creating database tables. */
define('DB_CHARSET', 'utf8');

/** The Database Collate type. Don't change this if in doubt. */
define('DB_COLLATE', '');

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define('AUTH_KEY',         'BtmTbK8EoV3zWfc0bmRyXNBP6BIoXvQSP4jzkwOpM9WwgREWy2l7VYeRHk8nYAKK');
define('SECURE_AUTH_KEY',  '01VR2AzkUQpY30zVO9JJveURFgLu2cSDMUdoh6qXDP4H0RJSdpgc8aQjzj4hPxv0');
define('LOGGED_IN_KEY',    'D81KBAFf68I1F6w40rR7s5lod8AeDCweuFRi0KWvcmz8ydDSZpGI27IG9RPa1Gru');
define('NONCE_KEY',        'TJerKE8IYBrTBFmuJPlxNoBmlQn3cnIGyIUCjfoXAZHgx3oL0wCSzGH0nljLCRZ0');
define('AUTH_SALT',        'bW41kwskATHnjOuPt1RSy4Zh4oUE79y3IJFxjL2UVZqledrmAWARe9M5RjluDAfk');
define('SECURE_AUTH_SALT', 'P6Ol0yAu21ifYhSu1ISMfJqLIPqUtDtLum0ZGrGGyh8XDqd08cXPPKwVjzW7htCp');
define('LOGGED_IN_SALT',   'JjWp2zVh7nttAJO5cFyoKKBTh6NyCooC1f5oap8KYKeSEZ1tZpm1eUpGFYJxavPj');
define('NONCE_SALT',       'ZYo9O1EhCrnJACN4aWLeIP7uUq7DgFNmfJ58D9eQGsuiYUv0OZmjpYlJsFOXPriB');

/**
 * Other customizations.
 */
define('FS_METHOD','direct');define('FS_CHMOD_DIR',0755);define('FS_CHMOD_FILE',0644);
define('WP_TEMP_DIR',dirname(__FILE__).'/wp-content/uploads');

/**
 * Turn off automatic updates since these are managed upstream.
 */
define('AUTOMATIC_UPDATER_DISABLED', true);


/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix  = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the Codex.
 *
 * @link https://codex.wordpress.org/Debugging_in_WordPress
 */
define('WP_DEBUG', false);

/* That's all, stop editing! Happy blogging. */

/** Absolute path to the WordPress directory. */
if ( !defined('ABSPATH') )
	define('ABSPATH', dirname(__FILE__) . '/');

/** Sets up WordPress vars and included files. */
require_once(ABSPATH . 'wp-settings.php');
