var input = File.ReadAllText("input.txt")
  .Split("\n")
  .Select(int.Parse)
  .ToArray();

Range RangeFrom(int start, int length) => start..(start + length);

int Measurements(int[] numbers, int winSize) {
    var increments = 0;
    for (var i = 0; i < numbers.Length - winSize; i++) {
        var a = numbers[RangeFrom(i, winSize)].Sum();
        var b = numbers[RangeFrom(i+1, winSize)].Sum();
        if (a < b) increments++;
    }
    return increments;
}

Console.WriteLine(Measurements(input, 1));
Console.WriteLine(Measurements(input, 3));