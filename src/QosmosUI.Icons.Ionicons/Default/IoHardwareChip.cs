// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoHardwareChip : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M352,128H160a32,32,0,0,0-32,32V352a32,32,0,0,0,32,32H352a32,32,0,0,0,32-32V160A32,32,0,0,0,352,128Zm0,216a8,8,0,0,1-8,8H168a8,8,0,0,1-8-8V168a8,8,0,0,1,8-8H344a8,8,0,0,1,8,8Z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "rect");
		builder.AddAttribute(17, "x", "160");
		builder.AddAttribute(18, "y", "160");
		builder.AddAttribute(19, "width", "192");
		builder.AddAttribute(20, "height", "192");
		builder.AddAttribute(21, "rx", "8");
		builder.AddAttribute(22, "ry", "8");
		builder.CloseElement();
		builder.OpenElement(23, "path");
		builder.AddAttribute(24, "d", "M464,192a16,16,0,0,0,0-32H448V128a64.07,64.07,0,0,0-64-64H352V48a16,16,0,0,0-32,0V64H272V48a16,16,0,0,0-32,0V64H192V48a16,16,0,0,0-32,0V64H128a64.07,64.07,0,0,0-64,64v32H48a16,16,0,0,0,0,32H64v48H48a16,16,0,0,0,0,32H64v48H48a16,16,0,0,0,0,32H64v32a64.07,64.07,0,0,0,64,64h32v16a16,16,0,0,0,32,0V448h48v16a16,16,0,0,0,32,0V448h48v16a16,16,0,0,0,32,0V448h32a64.07,64.07,0,0,0,64-64V352h16a16,16,0,0,0,0-32H448V272h16a16,16,0,0,0,0-32H448V192ZM384,352a32,32,0,0,1-32,32H160a32,32,0,0,1-32-32V160a32,32,0,0,1,32-32H352a32,32,0,0,1,32,32Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
