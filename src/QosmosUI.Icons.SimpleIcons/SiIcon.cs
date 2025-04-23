// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiIcon : ComponentBase
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
		builder.AddAttribute(15, "d", "M1.92669 23.93457c-.93754-.17758-1.70436-.94464-1.88217-1.88241-.31993-1.6878 1.13237-3.1401 2.82018-2.82018.93754.17781 1.7046.94463 1.8824 1.88217.31993 1.68804-1.13237 3.14034-2.82041 2.82042zM21.13507 4.76808c-.93754-.1778-1.7046-.94463-1.8824-1.8824-.31993-1.68805 1.13284-3.14034 2.82065-2.82019.93777.17805 1.70436.94487 1.88217 1.88241.31992 1.6878-1.13261 3.1401-2.82042 2.82018zm-9.11415 1.24226c1.1475 0 2.21912.32347 3.13017.88292l2.58538-2.58562c-1.59582-1.1877-3.57352-1.89092-5.71555-1.89092-5.29278 0-9.58347 4.29045-9.58347 9.58323 0 2.14227.70321 4.11997 1.89116 5.7158l2.58538-2.5854c-.55945-.91105-.88268-1.9829-.88268-3.1304 0-3.30799 2.68162-5.98961 5.9896-5.98961zm5.10664 2.85936c.55969.91106.88292 1.98267.88292 3.13018 0 3.30798-2.68162 5.9896-5.98961 5.9896-1.1475 0-2.21935-.323-3.13041-.88268L6.30508 19.6922c1.59582 1.18794 3.57352 1.89115 5.71579 1.89115 5.29278 0 9.58323-4.29045 9.58323-9.58346 0-2.14227-.70345-4.11974-1.89092-5.7158Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
