using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake.Model.Entities;
using Snake.View;
using System;
using System.Drawing;

namespace Snake.Tests
{
    [TestClass]
    public class ViewTests
    {
        [DataTestMethod]
        [DataRow(5, 5, 1, 3)]
        [DataRow(5, 5, 0, 0)]
        [DataRow(10, 10, 9, 9)]
        [DataRow(5, 10, 0, 9)]
        [DataRow(10, 10, 9, 0)]
        public void CorrectPositionFoodViewTest(int width, int height, int x, int y)
        {
            var view = new TextViewer();
            var targetFrame = new Frame(new Size(width, height));
            var food = new Food(new Point(x, y));

            var frame = new Frame(new Size(width, height));
            frame.Pixels[y, x] = CharIcons.FoodIcon;
            view.Draw(targetFrame, food);

            targetFrame.Pixels.Should().BeEquivalentTo(frame);
        }

        [DataTestMethod]
        [DataRow(5, 5, 0, -1)]
        [DataRow(5, 5, -1000, -1)]
        [DataRow(10, 5, 10, 0)]
        [DataRow(5, 5, 0, 9)]
        [DataRow(0, 1, 0, 0)]
        public void IncorrectPositionFoodViewTest(int width, int height, int x, int y)
        {
            var view = new TextViewer();
            var targetFrame = new Frame(new Size(width, height));
            var food = new Food(new Point(x, y));

            Action action = () => { view.Draw(targetFrame, food); };
            action.Should().Throw<Exception>();
        }

        [DataTestMethod]
        [DataRow(5, 5, BorderType.Horizontal, 0, 0, 1)]
        [DataRow(3, 1, BorderType.Horizontal, 0, 0, 3)]
        [DataRow(1, 1, BorderType.Horizontal, 0, 0, 1)]
        [DataRow(1, 1, BorderType.Vertical, 0, 0, 1)]
        [DataRow(5, 5, BorderType.Vertical, 0, 4, 5)]
        [DataRow(3, 3, BorderType.Horizontal, 2, 2, 1)]
        [DataRow(3, 3, BorderType.Vertical, 2, 2, 1)]
        [DataRow(5, 10, BorderType.Horizontal, 0, 0, 5)]
        [DataRow(5, 10, BorderType.Horizontal, 0, 4, 5)]
        [DataRow(5, 10, BorderType.Vertical, 0, 0, 10)]
        [DataRow(5, 10, BorderType.Vertical, 9, 0, 10)]
        public void OneBorderCorrectPositionViewTest(int width, int height, BorderType type, int x, int y, int length)
        {
            var view = new TextViewer();
            var targetFrame = new Frame(new Size(width, height));
            var border = new Border(type, new Point(x, y), length);

            var frame = new Frame(new Size(width, height));
            var cx = x;
            var cy = y;

            for (int i = 0; i < length; i++)
            {
                frame.Pixels[cy, cx] = CharIcons.BorderIcon;
                cx += type == BorderType.Horizontal ? 1 : 0;
                cy += type == BorderType.Vertical ? 1 : 0;
            }

            view.Draw(targetFrame, border);

            targetFrame.Pixels.Should().BeEquivalentTo(frame);
        }


        [DataTestMethod]
        [DataRow(1, 0, BorderType.Horizontal, 0, 0, 1)]
        [DataRow(5, 5, BorderType.Vertical, 0, 0, 6)]
        [DataRow(5, 5, BorderType.Vertical, 0, 3, 3)]
        [DataRow(5, 5, BorderType.Vertical, -1, 3, 1)]
        public void OneBorderIncorrectPositionViewTest(int width, int height, BorderType type, int x, int y, int length)
        {
            var view = new TextViewer();
            var targetFrame = new Frame(new Size(width, height));
            var border = new Border(type, new Point(x, y), length);

            Action action = () => { view.Draw(targetFrame, border); };

            action.Should().Throw<Exception>();
        }
    }
}
