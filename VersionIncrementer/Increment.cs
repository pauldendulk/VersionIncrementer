namespace VersionIncrementer
{
    internal enum Increment
    {
        /// <summary>
        /// Increments the major version, sets major and minor to 0 and removes the pre-release tag if present.
        /// </summary>
        Major,
        /// <summary>
        /// Increments the minor version and sets the minor version to 0 and removes the pre-release tag if present.
        /// </summary>
        Minor,
        /// <summary>
        /// Increments the patch version and removes the pre-release tag if present.
        /// </summary>
        Patch,
        /// <summary>
        /// Increments the pre-release if present. If not present the major version will be incremented, the minor and
        /// patch version will be set to 0 and a pre-release tag will be added set to 0 (e.g. 4.0.0-beta.0)
        /// </summary>
        PreRelease
    }
}
