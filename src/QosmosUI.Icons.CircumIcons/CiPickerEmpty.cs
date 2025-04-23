// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiPickerEmpty : ComponentBase
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
		builder.AddAttribute(14, "id", "Picker_Empty");
		builder.AddAttribute(15, "data-name", "Picker Empty");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M20.94,5.876a2.805,2.805,0,0,0-.84-2.01,2.856,2.856,0,0,0-3.97,0l-2.21,2.21-.75-.75a.8.8,0,0,0-1.1,0,.785.785,0,0,0,0,1.1l.75.75-8.77,8.76a3.248,3.248,0,0,0-.92,2.13l-.07,1.52a1.311,1.311,0,0,0,.38.97,1.332,1.332,0,0,0,.91.38h.06l1.52-.07a3.248,3.248,0,0,0,2.13-.92l8.76-8.77.75.75a.8.8,0,0,0,1.1,0,.785.785,0,0,0,0-1.1l-.75-.75L20.1,7.9A2.828,2.828,0,0,0,20.94,5.876ZM7.35,19.236a2.22,2.22,0,0,1-1.46.63l-1.53.07a.243.243,0,0,1-.21-.09.3.3,0,0,1-.09-.21l.07-1.53a2.22,2.22,0,0,1,.63-1.46l8.77-8.76,2.59,2.59ZM19.4,7.2l-2.18,2.18-2.59-2.59,2.21-2.22a1.861,1.861,0,0,1,2.56,0,1.846,1.846,0,0,1,.54,1.31A1.869,1.869,0,0,1,19.4,7.2Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
