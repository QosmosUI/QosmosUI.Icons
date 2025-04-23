// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoIdBadge : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M10.75 3h2.5c.464 0 .909.184 1.237.513.329.328.513.773.513 1.237V7h5.25c.464 0 .909.184 1.237.513.329.328.513.773.513 1.237v10.5c0 .464-.184.909-.513 1.237A1.746 1.746 0 0 1 20.25 21H3.75A1.75 1.75 0 0 1 2 19.25V8.75c0-.464.184-.909.513-1.237A1.746 1.746 0 0 1 3.75 7H9V4.75c0-.464.184-.909.513-1.237A1.746 1.746 0 0 1 10.75 3Zm3.646 6.573A1.753 1.753 0 0 1 13.25 10h-2.5a1.753 1.753 0 0 1-1.732-1.5H3.75a.25.25 0 0 0-.25.25v10.5c0 .138.112.25.25.25h16.5a.25.25 0 0 0 .25-.25V8.75a.25.25 0 0 0-.25-.25h-5.268c-.06.416-.268.797-.586 1.073Zm-8.25 1.573A.504.504 0 0 1 6.5 11h3c.133 0 .26.053.354.146A.504.504 0 0 1 10 11.5v5c0 .133-.053.26-.146.354A.504.504 0 0 1 9.5 17h-3a.504.504 0 0 1-.354-.146A.504.504 0 0 1 6 16.5v-5c0-.133.053-.26.146-.354ZM10.5 4.75v3.5a.25.25 0 0 0 .25.25h2.5a.25.25 0 0 0 .25-.25v-3.5a.25.25 0 0 0-.25-.25h-2.5a.25.25 0 0 0-.25.25Zm.72 7.47a.747.747 0 0 1 .53-.22h5.5c.199 0 .39.079.53.22a.747.747 0 0 1 0 1.06.747.747 0 0 1-.53.22h-5.5a.747.747 0 0 1-.53-.22.747.747 0 0 1 0-1.06Zm0 2.525a.747.747 0 0 1 .53-.22h3.5c.199 0 .39.079.53.22a.747.747 0 0 1 0 1.06.747.747 0 0 1-.53.22h-3.5a.747.747 0 0 1-.53-.22.747.747 0 0 1 0-1.06Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
