// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiQi : ComponentBase
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
		builder.AddAttribute(15, "d", "M16.5742 0c-.8422 0-1.525.6826-1.525 1.5247 0 .8424.6828 1.525 1.525 1.525s1.5247-.6826 1.5247-1.525C18.0989.6826 17.4164 0 16.5742 0zm-4.6371 2.856c-1.7103.0124-3.4264.5973-4.8392 1.7828-3.2263 2.7071-3.6471 7.5175-.94 10.7439 1.4616 1.7419 3.5365 2.6653 5.6439 2.7208.2966 0 .2966.293.2966.293v2.65s.0002 2.7624 2.6567 2.9532c.2952.0103.2953-.295.2953-.295V3.7857s0-.2943-.295-.415a7.665 7.665 0 0 0-2.8183-.5147zm4.7479 1.662c-.1097-.0016-.1097.1789-.1097.3891v11.1466c0 .2941 0 .5266.2948.2954.0104-.009.0211-.0175.0318-.0266 3.2265-2.707 3.6474-7.5175.94-10.7437a7.5925 7.5925 0 0 0-.9713-.9659c-.083-.0656-.1427-.0941-.1856-.0948zm-4.7515 1.3885c.165 0 .165.1642.165.1642v8.8198s0 .1644-.165.1644c-1.2823-.0192-2.5496-.5735-3.4386-1.633-1.6245-1.936-1.3719-4.8217.5639-6.4464.8395-.7046 1.8582-1.0549 2.8747-1.069z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
