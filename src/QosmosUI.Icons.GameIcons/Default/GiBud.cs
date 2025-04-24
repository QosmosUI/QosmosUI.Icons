// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBud : ComponentBase
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
		builder.AddAttribute(14, "d", "M384.125 18.97c-70.015 129.283-252.07 74.705-332.5 193.757l38.88 103.666c22.01-21.787 47.782-40.787 79.567-54.06l9.258-3.868 3.2 9.51c12.575 37.39 23.49 94.565 26.86 147.505l102.616-30.894c22.346-120.723 64.364-227.22 179.244-188.4-.588-.9-1.215-1.802-1.844-2.686-25.24-32.43-76.745-57.15-126.562-53.344-7.054 6.68-14.54 13.147-22.156 19.75-41.628 36.097-88.005 75.316-100.375 170.75l-18.563-2.406c13.072-100.845 65.095-146.402 106.688-182.47 20.796-18.032 38.698-33.91 49.125-53 10.15-18.584 14.12-40.507 6.562-73.81zm99.906 61.968c-25.515 2.268-52.788 3.074-82.03 1.624-2.063 6.823-4.76 13.198-8.03 19.188-3.806 6.966-8.29 13.374-13.25 19.438 22.365.908 44.225 6.32 63.905 15.124l39.406-55.375zM92.966 112.686c-24.006 18.624-41.328 40.01-55.32 62.77l6.193 16.51c15.573-19.714 34.12-34.565 54.695-46.66l-5.568-32.62zm-65.36 89.218c-9.833 47.09-12.01 104.668-2.27 155.688 11.808 61.856 40.106 112.43 90.153 127.283 34.535 10.248 83.65 10.54 126.72-4.996 38.26-13.802 71.604-39.362 88.542-81.42l-120.473 36.27c.24 8.67.253 17.144-.004 25.293l-18.68-.587c1.737-55.24-9.873-129.092-23.745-175.46-39.45 18.767-68.732 47.248-94.04 79.536l-14.71-11.53c5.46-6.967 11.147-13.825 17.107-20.503l-48.6-129.576z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
