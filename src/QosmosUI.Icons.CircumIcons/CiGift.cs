// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiGift : ComponentBase
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
		builder.AddAttribute(14, "id", "Gift");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M19.435,5.568h-2.38a1.979,1.979,0,0,0-.51-1.92,2.022,2.022,0,0,0-2.83,0L12,5.367l-1.71-1.719a2,2,0,0,0-2.83,0,1.979,1.979,0,0,0-.51,1.92H4.565a1.5,1.5,0,0,0-1.5,1.5v1A1.487,1.487,0,0,0,4,9.448v8.99a2.507,2.507,0,0,0,2.5,2.5h11a2.5,2.5,0,0,0,2.5-2.5V9.458a1.509,1.509,0,0,0,.94-1.39v-1A1.5,1.5,0,0,0,19.435,5.568ZM8.165,4.357a1,1,0,0,1,1.41,0l1.21,1.211H8.015A.989.989,0,0,1,8.165,4.357ZM11,19.938H6.5a1.5,1.5,0,0,1-1.5-1.5V9.568h6Zm0-11.37H4.565a.5.5,0,0,1-.5-.5v-1a.5.5,0,0,1,.5-.5H11Zm3.43-4.211A1,1,0,0,1,16,5.568h-2.78ZM19,18.438a1.5,1.5,0,0,1-1.5,1.5H13V9.568h6Zm.94-10.37a.5.5,0,0,1-.5.5H13v-2h6.44a.5.5,0,0,1,.5.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
