// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiTabletopPlayers : ComponentBase
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
		builder.AddAttribute(14, "d", "M134.865 113.46c-7.463.026-15.134 2.977-22.38 8.663-9.658 7.582-18.055 20.015-22.157 35.324-4.102 15.31-3.047 30.274 1.527 41.67 4.575 11.396 12.238 18.958 21.91 21.55 9.67 2.59 20.09-.126 29.75-7.708 9.658-7.583 18.055-20.016 22.157-35.325 4.102-15.31 3.047-30.274-1.527-41.67-4.575-11.396-12.24-18.96-21.91-21.55-2.418-.65-4.882-.965-7.37-.956zm242.27 0c-2.488-.01-4.954.306-7.37.954-9.672 2.59-17.337 10.155-21.91 21.55-4.576 11.397-5.63 26.362-1.527 41.67 4.102 15.31 12.497 27.743 22.156 35.325 9.66 7.58 20.08 10.297 29.75 7.706 9.67-2.59 17.338-10.153 21.912-21.55 4.575-11.395 5.626-26.36 1.524-41.67-4.102-15.308-12.495-27.74-22.154-35.323-7.245-5.686-14.918-8.638-22.38-8.664zM88.387 226.04c-10.146 2.133-18.06 6.477-24.82 12.648-9.882 9.023-17.314 22.553-23.03 39.7-10.6 31.8-15.044 75.344-22.062 120.153H150.97c-.04-44.9-.513-88.924-6.804-121.28-3.203-16.47-7.97-29.787-14.098-38.57-6.872 1.342-13.968 1.24-20.963-.635-8.012-2.147-14.98-6.376-20.718-12.014zm335.226 0c-5.74 5.64-12.705 9.868-20.718 12.015-6.994 1.874-14.09 1.978-20.96.636-6.127 8.785-10.9 22.1-14.1 38.57-6.292 32.356-6.766 76.38-6.804 121.28h132.493c-7.017-44.808-11.462-88.353-22.062-120.153-5.714-17.146-13.145-30.676-23.028-39.7-6.758-6.17-14.672-10.514-24.82-12.646zm-240.615 69.5v23H201v-23h-18.002zm80.002 0v23h18.002v-23H263zm-94.857 41c.18 4.613.313 9.292.425 14h174.864c.112-4.708.248-9.387.427-14H168.142z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
