// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiAurelia : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.716 4.636L13.49 6.122l-2.295-3.439 2.228-1.486zM17.527 14.967l3.806 5.703-4.533 3.025-3.806-5.703-.664-.995 4.533-3.025zM11.817 18.777l.838 1.256-3.45 2.303-1.503-2.25.754-.504 2.697-1.8zM19.413 12.27l.968-.645 1.501 2.25-2.227 1.487-.838-1.256 1.26-.84zm-.596 1.836l-.664-.995 1.26-.84.664.994zM3.792 12.593l-.753.503L.744 9.657l3.45-2.302 1.61 2.41-2.698 1.8 2.697-1.8.686 1.029zM11.513 5.954l.687 1.029-4.534 3.025L6.98 8.98 3.21 3.33 7.742.305zM14.749 5.282l-1.26.84-.686-1.028-1.609-2.41 2.228-1.487 2.295 3.439zM9.12 20.577l-.664-.995 2.697-1.8.664.995zM18.817 14.106l-.664-.995 1.26-.84.664.994zM3.792 12.593l-.686-1.028 2.697-1.8.686 1.029zM13.489 6.122l-.686-1.028 1.26-.84.686 1.028zM17.527 14.967l-4.533 3.025-.664-.995 4.533-3.025zM11.513 5.954l.687 1.029-4.534 3.025L6.98 8.98zM2.507 5.132l.855 1.283-1.282.855-.856-1.282zM7.127 20.505l.856 1.283-1.282.855-.856-1.282zM3.754 21.797L0 16.125 20.063 2.706 24 8.287z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
