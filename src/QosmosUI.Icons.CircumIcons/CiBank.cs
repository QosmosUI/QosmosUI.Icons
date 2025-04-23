// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiBank : ComponentBase
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
		builder.AddAttribute(14, "id", "Bank");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.505,17.943V10.362a1.491,1.491,0,0,0,1.39-1.12,1.468,1.468,0,0,0-.7-1.68l-7.45-4.3a1.521,1.521,0,0,0-1.49,0l-7.45,4.3a1.468,1.468,0,0,0-.7,1.68,1.487,1.487,0,0,0,1.45,1.12h.13v7.57h-.12a1.5,1.5,0,0,0,0,3h14.87a1.5,1.5,0,0,0,.07-2.989ZM4.555,9.362a.505.505,0,0,1-.25-.94l7.45-4.289a.474.474,0,0,1,.49,0L19.7,8.422a.5.5,0,0,1-.25.94Zm13.95,1v7.57H14.9v-7.57Zm-4.61,0v7.57h-3.61v-7.57Zm-4.61,0v7.57h-3.6v-7.57Zm10.15,9.57H4.565a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5h14.87a.5.5,0,0,1,.5.5A.5.5,0,0,1,19.435,19.932Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
