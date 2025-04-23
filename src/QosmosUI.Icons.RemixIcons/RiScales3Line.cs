// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiScales3Line : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.9985 2L12.9979 3.278L17.9985 4.94591L21.631 3.73509L22.2634 5.63246L19.2319 6.643L22.3272 15.1549C21.2353 16.2921 19.6996 17 17.9985 17C16.2975 17 14.7618 16.2921 13.6699 15.1549L16.7639 6.643L12.9979 5.387V19H16.9985V21H6.99854V19H10.9979V5.387L7.23192 6.643L10.3272 15.1549C9.23528 16.2921 7.69957 17 5.99854 17C4.2975 17 2.76179 16.2921 1.66992 15.1549L4.76392 6.643L1.73363 5.63246L2.36608 3.73509L5.99854 4.94591L10.9979 3.278L10.9985 2H12.9985ZM17.9985 9.10267L16.04 14.4892C16.628 14.8201 17.2979 15 17.9985 15C18.6992 15 19.3691 14.8201 19.957 14.4892L17.9985 9.10267ZM5.99854 9.10267L4.04004 14.4892C4.62795 14.8201 5.29792 15 5.99854 15C6.69916 15 7.36912 14.8201 7.95703 14.4892L5.99854 9.10267Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
