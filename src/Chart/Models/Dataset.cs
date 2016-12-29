﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chart.Models
{
    // TODO: Allow scatter datasets to be accepted as data.
    public class Dataset
    {
        /// <summary>
        /// The data to plot in a line.
        /// </summary>
        public IList<double> Data { get; set; }

        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; }
    }
}
