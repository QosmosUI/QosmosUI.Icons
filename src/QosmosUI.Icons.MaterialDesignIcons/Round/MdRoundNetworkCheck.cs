// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.MaterialDesignIcons.Round;

public class MdRoundNetworkCheck : ComponentBase
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
		builder.AddAttribute(14, "d", "M0 0h24v24H0V0z");
		builder.AddAttribute(15, "fill", "none");
		builder.CloseElement();
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M15.9 5c-.17 0-.32.09-.41.23l-.07.15-5.18 11.65c-.16.29-.26.61-.26.96 0 1.11.9 2.01 2.01 2.01.96 0 1.77-.68 1.96-1.59l.01-.03L16.4 5.5c0-.28-.22-.5-.5-.5zM2.06 10.06c.51.51 1.33.55 1.89.09 2.76-2.26 6.24-3.18 9.58-2.76l1.19-2.68c-4.35-.78-8.96.3-12.57 3.25-.64.53-.68 1.51-.09 2.1zm19.88 0c.59-.59.55-1.57-.1-2.1-1.36-1.11-2.86-1.95-4.44-2.53l-.53 2.82c1.13.47 2.19 1.09 3.17 1.89.58.46 1.39.43 1.9-.08zm-4.03 4.03c.6-.6.56-1.63-.14-2.12-.46-.33-.94-.61-1.44-.86l-.55 2.92c.11.07.22.14.32.22.57.4 1.33.32 1.81-.16zm-11.83-.01c.5.5 1.27.54 1.85.13.94-.66 2.01-1.06 3.1-1.22l1.28-2.88c-2.13-.06-4.28.54-6.09 1.84-.69.51-.74 1.53-.14 2.13z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
