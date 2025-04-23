// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiProtoncalendar : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.172 14.818V21.85h-4.276v-1.147c0-.584.21-1.151.592-1.596l3.684-4.288zm-4.93 5.884c0-.741.266-1.46.75-2.022l4.673-5.32c.522-.591 1.524-.92 2.262-.92h.967V7.007a1.919 1.919 0 0 0-1.928-1.914H0v14.295c0 1.36 1.11 2.462 2.482 2.462h7.76v-1.147zM18.8 5.197c.483.485.749 1.128.747 1.81v5.434H24V4.613c0-1.36-1.11-2.462-2.482-2.462H2.482A2.473 2.473 0 0 0 .006 4.438h16.96c.694 0 1.345.27 1.834.76zm.34 14.742c.817 0 1.45-.451 1.45-1.136a.953.953 0 0 0-.79-.971v-.013a.962.962 0 0 0 .485-.346.944.944 0 0 0 .185-.565c0-.632-.549-1.081-1.343-1.081-.99 0-1.384.712-1.415 1.21h.843a.54.54 0 0 1 .577-.495c.318 0 .549.196.549.48 0 .283-.213.473-.732.473h-.3v.713h.346c.536 0 .807.176.807.492s-.26.532-.655.532a.673.673 0 0 1-.686-.51h-.873c.063.733.683 1.222 1.551 1.217zm2-3.39v.806l.79-.532v3.06h.82v-3.988h-.635l-.974.655z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
