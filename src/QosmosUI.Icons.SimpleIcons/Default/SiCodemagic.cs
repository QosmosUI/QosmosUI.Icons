// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiCodemagic : ComponentBase
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
		builder.AddAttribute(15, "d", "M22.833 10.117L16.937 7.24c-.07-.035-.106-.106-.142-.177l-2.912-5.896c-.498-1.03-1.776-1.457-2.807-.96a2.09 2.09 0 0 0-.959.96L7.205 7.063a.81.81 0 0 1-.142.177l-5.896 2.913c-1.03.497-1.457 1.776-.96 2.806a2.1 2.1 0 0 0 .96.96l5.896 2.876c.07.036.106.107.142.142l2.948 5.896c.497 1.03 1.776 1.457 2.806.96a2.09 2.09 0 0 0 .959-.96l2.877-5.896c.036-.07.107-.142.142-.142l5.896-2.912c1.03-.498 1.457-1.776.96-2.806-.178-.427-.533-.746-.96-.96zm-4.368.427l-2.735 2.38c-.533.497-.924 1.136-1.066 1.847l-.71 3.551c-.036.143-.178.25-.32.214-.071 0-.107-.036-.142-.107l-2.38-2.735c-.497-.533-1.137-.923-1.847-1.066l-3.552-.71c-.142-.035-.249-.178-.213-.32 0-.07.035-.106.106-.142l2.735-2.38c.533-.497.924-1.136 1.066-1.847l.71-3.551c.036-.143.178-.25.32-.214a.27.27 0 0 1 .142.071l2.38 2.735c.497.533 1.137.924 1.847 1.066l3.552.71c.142.036.249.178.213.32a.38.38 0 0 1-.106.178z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
