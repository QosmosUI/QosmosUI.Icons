// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiDashboard3Fill : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M12 2C17.5228 2 22 6.47715 22 12C22 17.5228 17.5228 22 12 22C6.47715 22 2 17.5228 2 12C2 6.47715 6.47715 2 12 2ZM16.5962 7.40381C16.3916 7.19926 16.0697 7.17128 15.8329 7.33748C12.9438 9.36549 11.3126 10.5661 10.9393 10.9393C10.3536 11.5251 10.3536 12.4749 10.9393 13.0607C11.5251 13.6464 12.4749 13.6464 13.0607 13.0607C13.2796 12.8417 14.479 11.2095 16.6587 8.16418C16.8267 7.92955 16.8002 7.60784 16.5962 7.40381ZM17.5 11C16.9477 11 16.5 11.4477 16.5 12C16.5 12.5523 16.9477 13 17.5 13C18.0523 13 18.5 12.5523 18.5 12C18.5 11.4477 18.0523 11 17.5 11ZM6.5 11C5.94772 11 5.5 11.4477 5.5 12C5.5 12.5523 5.94772 13 6.5 13C7.05228 13 7.5 12.5523 7.5 12C7.5 11.4477 7.05228 11 6.5 11ZM8.81802 7.40381C8.4275 7.01328 7.79433 7.01328 7.40381 7.40381C7.01328 7.79433 7.01328 8.4275 7.40381 8.81802C7.79433 9.20854 8.4275 9.20854 8.81802 8.81802C9.20854 8.4275 9.20854 7.79433 8.81802 7.40381ZM12 5.5C11.4477 5.5 11 5.94772 11 6.5C11 7.05228 11.4477 7.5 12 7.5C12.5523 7.5 13 7.05228 13 6.5C13 5.94772 12.5523 5.5 12 5.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
