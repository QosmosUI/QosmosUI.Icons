// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMinimize2 : ComponentBase
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
		builder.AddAttribute(14, "id", "Minimize_2");
		builder.AddAttribute(15, "data-name", "Minimize 2");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M3.563,11.016H9.146A2.057,2.057,0,0,0,10.3,10.8a1.6,1.6,0,0,0,.717-1.436V3.566a.5.5,0,0,0-1,0V8.974a2.481,2.481,0,0,1-.022.689c-.115.373-.468.353-.777.353H3.563a.5.5,0,0,0,0,1Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M11.013,20.438V14.855a2.065,2.065,0,0,0-.22-1.15,1.6,1.6,0,0,0-1.437-.717H3.563a.5.5,0,0,0,0,1H8.972a2.482,2.482,0,0,1,.689.022c.373.115.352.469.352.777v5.651a.5.5,0,0,0,1,0Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M20.437,12.984H14.854a2.057,2.057,0,0,0-1.15.221,1.6,1.6,0,0,0-.717,1.436v5.793a.5.5,0,0,0,1,0V15.026a2.481,2.481,0,0,1,.022-.689c.115-.373.468-.353.777-.353h5.651a.5.5,0,0,0,0-1Z");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M12.987,3.562V9.145a2.065,2.065,0,0,0,.22,1.15,1.6,1.6,0,0,0,1.437.717h5.793a.5.5,0,0,0,0-1H15.028a2.482,2.482,0,0,1-.689-.022c-.373-.115-.352-.469-.352-.777V3.562a.5.5,0,0,0-1,0Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
