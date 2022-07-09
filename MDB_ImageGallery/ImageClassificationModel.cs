using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MDB_ImageGallery
{
    class ImageClassificationModel
    {
        public struct ImageNetSettings
        {
            public const int imageHeight = 224;
            public const int imageWidth = 224;
            public const float mean = 117;
            public const bool channelsLast = true;
        }
        public string  tagsTsv = Path.Combine(Environment.CurrentDirectory, "assets", "images", "tags.tsv");
        public string imagesFolder = Path.Combine(Environment.CurrentDirectory, "assets", "images");
        public string inceptionPb = Path.Combine(Environment.CurrentDirectory, "assets", "inception", "tensorflow_inception_graph.pb");
        public string labelsTxt = Path.Combine(Environment.CurrentDirectory, "assets", "inception", "imagenet_comp_graph_label_strings.txt");
        public string predictImagePath;
        public ImageClassificationModel(string predictImagePath)
        {
            this.predictImagePath = predictImagePath;
        }

        public string Classification()
        {
            var modelScorer = new TFModelScorer(tagsTsv, imagesFolder, inceptionPb, labelsTxt);
            var prediction = (ImageNetDataProbability)modelScorer.Score(new ImageNetData() { ImagePath = this.predictImagePath, Label = "" });
            var pred = prediction.PredictedLabel;
            return pred.ToString();
        }
    }
}
