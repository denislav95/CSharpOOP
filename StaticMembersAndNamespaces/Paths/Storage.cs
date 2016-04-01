using System;
using Point;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Paths
{
    static class Storage
    {
        private const string PathMatcher = @"Path:\s+((?:Point\s*\((?:.*?),\s*(?:.*?),\s*(?:.*?)\)\s*)+)";
        private const string PointMatcher = @"Point\s*\((.*?),\s*(.*?),\s*(.*?)\)";

        public static void SaveToPathFile(string fileLocation, Path3D path)
        {
            File.WriteAllText(fileLocation, path.ToString());
        }

        public static Path3D LoadPathFromFile(string fileLocation)
        {
            string input = File.ReadAllText(fileLocation);
            if(!Regex.IsMatch(input, PathMatcher))
            {
                throw new ArgumentNullException("File doest not contain Path3D data");
            }

            string pathAsString = Regex.Match(input, PathMatcher).Groups[1].Value;
            var pointsInPath = new List<Point3D>();
            foreach (Match match in Regex.Matches(pathAsString, PointMatcher))
            {
                double deltaX = double.Parse(match.Groups[1].Value);
                double deltaY = double.Parse(match.Groups[2].Value);
                double deltaZ = double.Parse(match.Groups[3].Value);
                pointsInPath.Add(new Point3D(deltaX, deltaY, deltaZ));
            }

            Path3D pathFromFile = new Path3D(pointsInPath);
            return pathFromFile;
        }
    }
}
