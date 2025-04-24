// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiHashtag : ComponentBase
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
		builder.AddAttribute(14, "id", "Hashtag");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M20.435,15.506H16.2l.61-7h3.63a.5.5,0,0,0,.5-.5.5.5,0,0,0-.5-.5H16.9l.34-3.87a.509.509,0,0,0-.46-.54.5.5,0,0,0-.54.46l-.35,3.95H8.9l.34-3.87a.509.509,0,0,0-.46-.54.491.491,0,0,0-.54.46l-.35,3.95H3.565a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5h4.24l-.62,7H3.565a.5.5,0,0,0-.5.5.5.5,0,0,0,.5.5h3.54l-.34,3.86a.508.508,0,0,0,.45.54h.05a.516.516,0,0,0,.5-.46l.34-3.94h7l-.34,3.86a.508.508,0,0,0,.45.54h.05a.516.516,0,0,0,.5-.46l.34-3.94h4.33a.5.5,0,0,0,.5-.5A.5.5,0,0,0,20.435,15.506Zm-5.25,0H8.2l.61-7h7Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
