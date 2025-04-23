// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiCloudbees : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.87.283C3.081.283 0 3.32 0 7.05c0 3.732 3.082 6.767 6.87 6.767h2.429v-3.495h-2.43c-1.83 0-3.319-1.468-3.319-3.272 0-1.804 1.488-3.27 3.32-3.27.734 0 1.377.19 1.928.567l2.51-2.473C10.06.814 8.58.284 6.87.284zm5.152 2.231c-.066-.005-.141.08-.35.252a.457.457 0 0 0-.028.026L9.722 4.674c-.323.315-.29.203-.066.556a3.204 3.204 0 0 1 .532 1.749v9.991c0 3.73 3.096 6.747 6.908 6.747C20.907 23.717 24 20.7 24 16.97c0-3.728-3.093-6.75-6.904-6.75H13.76V6.979c0-1.495-.512-3.002-1.436-4.158-.175-.203-.234-.3-.3-.307zm5.246 11.209c1.762.088 3.168 1.502 3.168 3.247 0 1.802-1.5 3.264-3.342 3.264s-3.335-1.477-3.335-3.28v-3.219h3.509z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
