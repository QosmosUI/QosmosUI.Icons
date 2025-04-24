// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons.Default;

public class RiShoppingBagFill : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.0049 0.999695C14.7663 0.999695 17.0049 3.23827 17.0049 5.99969V7.99969H20.0049C20.5572 7.99969 21.0049 8.44741 21.0049 8.99969V20.9997C21.0049 21.552 20.5572 21.9997 20.0049 21.9997H4.00488C3.4526 21.9997 3.00488 21.552 3.00488 20.9997V8.99969C3.00488 8.44741 3.4526 7.99969 4.00488 7.99969H7.00488V5.99969C7.00488 3.23827 9.24346 0.999695 12.0049 0.999695ZM17.0049 10.9997H15.0049V11.9997C15.0049 12.552 15.4526 12.9997 16.0049 12.9997C16.5177 12.9997 16.9404 12.6137 16.9982 12.1163L17.0049 11.9997V10.9997ZM9.00488 10.9997H7.00488V11.9997C7.00488 12.552 7.4526 12.9997 8.00488 12.9997C8.51772 12.9997 8.94039 12.6137 8.99815 12.1163L9.00488 11.9997V10.9997ZM12.0049 2.99969C10.4072 2.99969 9.10122 4.24861 9.00998 5.82342L9.00488 5.99969V7.99969H15.0049V5.99969C15.0049 4.40201 13.756 3.09603 12.1812 3.00479L12.0049 2.99969Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
