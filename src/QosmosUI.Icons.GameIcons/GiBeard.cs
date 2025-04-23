// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiBeard : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M319 35.375c-27.305-.247-52.415 19.47-62.063 46.094-9.726-26.856-35.196-46.656-62.78-46.064-15.11.325-30.85 6.764-45 21.532-11.47 11.968-17.863 27.782-24.407 43.75-15 22.49-35.066 39.27-64.156 45.874 7 6.374 14.63 9.69 22.656 11.063-14.192 7.828-33.583 12.154-61.28 10.78 20.528 26.327 52.643 35.282 86.28 34.532 60.716-2.34 91.448-33.326 109.438-64.875l16.218 9.25c-20.387 35.754-59.15 71.513-127.28 74.094-.002.24 0 .48 0 .72 0 6.067 1.32 13.4 3.686 21.686l-.25-.468 29.5 114.875 4.625-38.626c17.095 31.46 37.67 64.792 56.532 93.97l1.624-46.127c5.83 38.514 20.68 73.426 39.062 106.97 9.337 13.507 15.25 21.78 15.25 21.78s6.953-9.693 17.875-25.562c.07-.1.152-.213.22-.313 20.76-32.818 38.056-67.256 46.438-105.906l-1.063 37.438c9.342-14.666 18.923-30.088 28.156-45.656v28.468l40.533-104.125c9.877-21.585 16.512-40.562 17.656-54.342-65.713-7.917-111.206-41.86-132.314-78.875l16.22-9.25c19.702 34.552 66.54 68.93 138.312 71.062 15.085-.3 29.905-3.623 45.593-11.313-14.823.118-27.478-1.08-38.53-3.437 23.34-5.136 43.576-16.795 56.125-37.97-102.54 21.26-90.343-61.02-127.188-99.468-14.37-14.994-30.37-21.424-45.687-21.562z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
