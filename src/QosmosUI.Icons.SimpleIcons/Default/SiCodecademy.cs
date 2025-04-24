// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCodecademy : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M23.827 19.729h-5.595c-.094 0-.17.058-.17.172v1.515c0 .094.058.17.172.17h5.594c.096 0 .172-.044.172-.164v-1.515c0-.105-.057-.166-.173-.166v-.014zM16.463 2.463c.016.034.03.067.047.12v18.79c0 .06-.02.096-.037.114a.168.168 0 01-.135.06H.153c-.038 0-.075 0-.097-.02A.181.181 0 010 21.393V2.564c0-.076.04-.134.096-.15h16.242c.04 0 .096.017.115.034v.016zM1.818 19.573c0 .072.038.135.096.152h12.643c.058-.019.096-.076.096-.154V4.402c0-.073-.039-.134-.098-.15H1.915c-.056.02-.096.073-.096.15l-.003 15.17zm5.174-8.375c.65 0 1.014.177 1.396.62.058.074.153.093.23.034l1.034-.92c.075-.044.058-.164.02-.224-.635-.764-1.554-1.244-2.74-1.244-1.59 0-2.79.795-3.255 2.206-.165.495-.24 1.126-.24 1.98 0 .854.075 1.483.255 1.98.465 1.425 1.665 2.204 3.255 2.204 1.2 0 2.115-.48 2.745-1.216.045-.074.06-.165-.015-.226l-1.037-.915c-.073-.047-.163-.047-.224.027-.39.45-.795.69-1.454.69-.706 0-1.245-.345-1.47-1.035-.136-.39-.166-.87-.166-1.483 0-.615.045-1.068.18-1.47.24-.66.766-1.008 1.486-1.008z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
