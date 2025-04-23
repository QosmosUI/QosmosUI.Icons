// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiMaximize2 : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Maximize_2");
		builder.AddAttribute(15, "data-name", "Maximize 2");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M10.513,3.066H4.93a2.058,2.058,0,0,0-1.15.22,1.6,1.6,0,0,0-.717,1.437v5.793a.5.5,0,0,0,1,0V5.107a2.521,2.521,0,0,1,.022-.689c.115-.373.469-.352.777-.352h5.651a.5.5,0,0,0,0-1Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M3.063,13.488v5.583a2.057,2.057,0,0,0,.221,1.15,1.6,1.6,0,0,0,1.436.717h5.793a.5.5,0,0,0,0-1H5.1a2.483,2.483,0,0,1-.689-.022c-.372-.115-.352-.469-.352-.777V13.488a.5.5,0,0,0-1,0Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M13.487,20.934H19.07a2.058,2.058,0,0,0,1.15-.22,1.6,1.6,0,0,0,.717-1.437V13.484a.5.5,0,0,0-1,0v5.409a2.521,2.521,0,0,1-.022.689c-.115.373-.469.352-.777.352H13.487a.5.5,0,0,0,0,1Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M20.937,10.512V4.929a2.057,2.057,0,0,0-.221-1.15,1.6,1.6,0,0,0-1.436-.717H13.487a.5.5,0,0,0,0,1H18.9a2.483,2.483,0,0,1,.689.022c.372.115.352.469.352.777v5.651a.5.5,0,0,0,1,0Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
