﻿using AmbientSounds.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmbientSounds.Services
{
    /// <summary>
    /// An interface for a provider of sound data.
    /// </summary>
    public interface ISoundDataProvider
    {
        /// <summary>
        /// Retrieves list of sound data available.
        /// </summary>
        /// <returns>A list of <see cref="Sound"/> instances.</returns>
        Task<IList<Sound>> GetSoundsAsync();

        /// <summary>
        /// Adds sound info to local list.
        /// </summary>
        /// <param name="s">The sound info to save.</param>
        Task AddLocalSoundAsync(Sound s);
    }
}
