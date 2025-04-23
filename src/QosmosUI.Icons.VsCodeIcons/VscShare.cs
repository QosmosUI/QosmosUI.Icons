// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscShare : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M5 4.00098H1.5L1 4.50098V14.501L1.5 15.001H12.5L13 14.501V11.5H12V14.001H2V5.00098H5V4.00098Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "fill-rule", "evenodd");
		builder.AddAttribute(17, "clip-rule", "evenodd");
		builder.AddAttribute(18, "d", "M6 11H5V8.5C5 6.08104 6.71776 4.06329 9 3.60002L9.00001 2.34885C9.00001 1.6039 9.60391 1 10.3489 1C10.7217 1 11.0779 1.15432 11.3329 1.42632L14.9795 5.31606V6.68394L11.3329 10.5737C11.0779 10.8457 10.7217 11 10.3489 11C9.60391 11 9 10.3961 9 9.65114L9 8.60178C8.06714 8.81236 7.61607 9.31244 7.36824 9.74614C7.18768 10.0621 7.09298 10.3875 7.04484 10.6402C7.02115 10.7646 7.00983 10.8656 7.0045 10.931C7.00184 10.9635 7.00072 10.9866 7.00025 10.9988L7.00019 11.0007C6.82645 11.0003 6.16755 11 6 11ZM10 4.5C7.89378 4.5 6.16778 6.12788 6.01152 8.1941C6.00389 8.29507 6 8.39708 6 8.5V10H6.1758C6.31381 9.55711 6.56019 9.03517 7 8.58307C7.44225 8.12846 8.08008 7.74446 9 7.58244C9.30193 7.52926 9.63424 7.5 10 7.5L10 9.65114C10 9.84381 10.1562 10 10.3489 10C10.4453 10 10.5374 9.96009 10.6034 9.88974L14.25 6L10.6034 2.11026C10.5374 2.03991 10.4453 2 10.3489 2C10.1562 2 10 2.15619 10 2.34886L10 4.5Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M7.00019 11.0007C7.05203 11.0008 7.06069 11.0006 7.00019 11.0007Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M7.00019 11.0007L6.99996 11.0079L6.99997 11.0065L6.99999 11.0039L7 11.0021L7.00019 11.0007V11.0007Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
