ColorManager colormanager = new ColorManager();

colormanager["red"] = new Color(255, 0, 0);
colormanager["green"] = new Color(0, 255, 0);
colormanager["blue"] = new Color(0, 0, 255);

colormanager["angry"] = new Color(255, 54, 0);
colormanager["peace"] = new Color(128, 211, 128);
colormanager["flame"] = new Color(211, 34, 20);

Color color1 = colormanager["red"].clone() as Color; 
Color color2 = colormanager["peace"].clone() as Color; 
Color color3 = colormanager["flame"].clone() as Color;

Console.ReadKey();
public abstract class ColorPrototype
{
    public abstract ColorPrototype clone();
}
public class Color : ColorPrototype
{
    int red;
    int green;
    int blue;
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }
    public override ColorPrototype clone()
    {
        Console.WriteLine("Cloning color RGB:{0,3},{1,3},{2,3}", red, green, blue);
        return this.MemberwiseClone() as ColorPrototype;
    }
}
public class ColorManager
{
    private Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();
    public ColorPrototype this[string key]
    {
        get { return colors[key]; }
        set { colors.Add(key, value); }
    }
}
