﻿using Microsoft.ML.Runtime.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering_Iris.DataStructures
{
    public class IrisData
    {
        [Column("0")]
        public float Label;

        [Column("1")]
        public float SepalLength;

        [Column("2")]
        public float SepalWidth;

        [Column("3")]
        public float PetalLength;

        [Column("4")]
        public float PetalWidth;

    }
}
